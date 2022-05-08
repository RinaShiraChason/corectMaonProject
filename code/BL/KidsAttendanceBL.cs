using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace BL
{
    public class KidsAttendanceBL
    {
        IMapper imapper;
        KidsAttendanceDAL _kids_AttendanceDal = new KidsAttendanceDAL();

        public KidsAttendanceBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }

        public List<KidsAttendanceDTO> GetAll()
        {
            List<KidsAttendance> l = _kids_AttendanceDal.GetAll();
            List<KidsAttendanceDTO> lDTO = imapper.Map<List<KidsAttendance>, List<KidsAttendanceDTO>>(l);
            return lDTO;
        }

        public bool update(KidsAttendanceDTO kids_Attendance)
        {
            KidsAttendance KidsAttendanceDal = imapper.Map<KidsAttendanceDTO, KidsAttendance>(kids_Attendance);
            bool b = _kids_AttendanceDal.update(KidsAttendanceDal);

            return b;
        }

        public object Delete(int attendanceId)
        {
            bool b = _kids_AttendanceDal.Delete(attendanceId);

            return b;
        }

        public bool SetKidAttendence(KidsAttendanceDTO kids_Attendance)
        {
            KidsAttendance KidsAttendanceDal = imapper.Map<KidsAttendanceDTO, KidsAttendance>(kids_Attendance);
            bool b = _kids_AttendanceDal.SetKidAttendence(KidsAttendanceDal);

            return b;
        }

        public bool AddKids_Attendance(KidsAttendanceDTO kids_Attendance)
        {
            KidsAttendance KidsAttendanceDal = imapper.Map<KidsAttendanceDTO, KidsAttendance>(kids_Attendance);
            bool b = _kids_AttendanceDal.AddKids_Attendance(KidsAttendanceDal);

            return b;
        }

        public bool SendEmailNoKidAttendence(int classId)
        {
            var kidsWithParents = _kids_AttendanceDal.GetNoKidAttendence(classId);
            foreach (var kid in kidsWithParents)
            {
                MailMessage msg = new MailMessage();
                //הכתובת ממנה ישלח המייל - מומלץ אותם נתונים שיצרת בגמייל
                msg.From = new MailAddress("maon.kidsit@gmail.com", "Kids It");
                msg.To.Add(kid.UserParent.Email);
                msg.Subject = "התרעה על חיסור ילדך מהמעון";
                msg.IsBodyHtml = true;
                StringBuilder htmlBody = new StringBuilder("<div style='text-align: center; color: #5b9bb6; width: 500px; border: 3px solid #ff4081;font-size:18px;'>" +
"<p>הי " + kid.UserParent.UserName + "</p>" +
"<p>.ילדך " + kid.NameKids + " <strong>לא</strong> הופיע/ה הבוקר במעון</p> " +
"<p>.נא לבדוק שחלילה הילד/ה לא נשכח/ה ברכב או בהסעה</p> " +
"<p>יום נעים, בריא ובטוח לכולנו!</p> " +
"<p>צוות המעון</p> " +
"<p style='color:#ff4081;font-size:24px;'>KIDS IT</p> " +
"</div>");
                // HTML יצירת מעטפת לקוד 
                var htmlView = AlternateView.CreateAlternateViewFromString(htmlBody.ToString(), new ContentType("text/html"));
                //עדכון עבור זיהוי תוכן בעברית 
                htmlView.ContentType.CharSet = Encoding.UTF8.WebName;
                //נעדכן את התוכן של ההודעה 
                msg.AlternateViews.Add(htmlView);
                // (ערכים קבועים אין צורך לשנות) Gmail יצירת אוביקט לשרת שליחת המייל של.
                SmtpClient smtp = new SmtpClient();
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                //פרטי החשבון שיצרת, הכתובת והסיסמא
                smtp.Credentials = new NetworkCredential("maon.kidsit@gmail.com", "KidsIt2022");
                smtp.EnableSsl = true;
                smtp.Timeout = int.MaxValue;
                //הפונקציה ששולחת בפועל את המייל 
                smtp.Send(msg);

            }

            return true;

        }

    }
}

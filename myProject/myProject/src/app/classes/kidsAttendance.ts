import { Kids } from "./Kids";

export interface KidsAttendance{
  attendanceId :number;
  currentDate :Date;
  isArrived :boolean;
  kidId :number;
  kid :Kids;

 
}
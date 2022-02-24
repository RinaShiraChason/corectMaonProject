import { Kids } from "./Kids";

export interface KidsAttendance{
  AttendanceId:number;
  CurrentDate:Date;
  IsArrived:boolean;
  KidId:number;
  Kid:Kids;

 
}
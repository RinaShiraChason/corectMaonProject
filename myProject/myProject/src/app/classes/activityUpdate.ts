import { Classes } from "./Classes";
import { User } from "./Users";

export interface ActivityUpdate {
  idActivityUpdate: number;
  dailyActivityDate: Date;
  dailyActivitySubject: string;
  dailyActivityInfo: string;
  classId?: number;
  class : Classes;
  userTeacher: User;
  teacherId:number;
}

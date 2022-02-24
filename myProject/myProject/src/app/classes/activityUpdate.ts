import { Classes } from "./Classes";
import { User } from "./Users";

export interface activityUpdate {
  IdActivityUpdate: number;
  DailyActivityDate: Date;
  DailyActivitySubject: string;
  DailyActivityInfo: string;
  ClassId?: number;
  Class: Classes;
  UserTeacher: User;
}

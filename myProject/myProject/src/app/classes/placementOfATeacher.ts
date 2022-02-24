import { Classes } from "./Classes";
import { User } from "./Users";

export interface PlacementOfATeacher {
  IdPlacementOfATeacher: number;
  IsMorning: boolean;
  DayInWeek: number;
  ClassId: number;
  TeacherId: number;
  Class: Classes;
  UserTeacher: User;
}

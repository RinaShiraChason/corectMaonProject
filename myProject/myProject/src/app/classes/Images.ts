import { Classes } from "./Classes";
import { User } from "./Users";

export interface Images {
  ImageId: number;
  ImageURL: string;
  ImageTitle: string;
  ImageData: string;
  ImageDate: Date;
  ClassId?: number;
  TeacherId: number;
  Class: Classes;
  UserTeacher: User;
}

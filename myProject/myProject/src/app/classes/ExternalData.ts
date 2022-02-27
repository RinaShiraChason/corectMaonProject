import { Classes } from "./Classes";
import { User } from "./Users";

export interface ExternalData {
  ExternalDataId: number;
  ExternalDataTitle: string;
  ExternalDataLink: string;
  ExternalDataDate: Date;
  ClassId?: number;
  TeacherId: number;
  Class: Classes;
  UserTeacher: User;
}

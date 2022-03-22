import { Classes } from "./Classes";
import { User } from "./Users";

export interface ExternalData {
  externalDataId : number;
  externalDataTitle : string;
  externalDataLink : string;
  externalDataDate : Date;
  classId?: number;
  teacherId: number;
  class: Classes;
  userTeacher: User;
}

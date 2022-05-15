import { Classes } from "./Classes";
import { User } from "./Users";

export interface Images {
  imageId: number;
  imageURL: string;
  imageTitle: string;
  imageData: string;
  imageDate: Date;
  classId?: number;
  teacherId: number;

  
  class: Classes;
  userTeacher: User;
}

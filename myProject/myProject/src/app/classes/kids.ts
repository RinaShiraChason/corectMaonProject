import { Classes } from "./Classes";
import { DayCare } from "./DayCare";
import { KidsAttendance } from "./KidsAttendance";
import { User } from "./Users";

export interface Kids{
    kidId :number;
    nameKids :string;
    tzKid :string;
    ageKids :number;
    classId:number;
    dateBorn :Date;
    parentId :number;
    class :Classes;
    userParent :User;
    kidsAttendance:KidsAttendance[];
    dayCare:DayCare[];

  

}
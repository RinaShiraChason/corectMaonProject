import { Kids } from "./Kids";

export interface DayCare{

     idDayCare :number;
     dateCare :Date;
     behaviorDayCare:string;
     dressDayCare :string;
     commentDayCare :string;
     sleepDayCare :string;
     foodDayCare :string;
     kidId :number;
     kid :Kids;
    
}
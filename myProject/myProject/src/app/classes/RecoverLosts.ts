import { User } from "./Users";

export interface RecoverLosts {
  RecoverLostsId: number;
  RecoverLostsInfo: string;
  RecoverLostsImage: string;
  RecoverLostsDate: Date;
  IdUser: number;
  User: User;
}

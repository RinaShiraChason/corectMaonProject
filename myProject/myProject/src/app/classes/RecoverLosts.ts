import { User } from "./Users";

export interface RecoverLosts {
  recoverLostsId: number;
  recoverLostsInfo: string;
  recoverLostsImage: string;
  recoverLostsDate: Date;
  idUser: number;
  user: User;
}

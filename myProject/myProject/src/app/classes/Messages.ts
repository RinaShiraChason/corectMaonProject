import { Kids } from "./Kids";
import { User } from "./Users";

export interface Messages {
  MessageId: number;
  MessageContent: string;
  MessageDateTime: Date;
  UserFromId: number;
  KidId: number;
  UserToId: number;
  UserFrom: User;
  UserTo: User;
  Kid: Kids;
}

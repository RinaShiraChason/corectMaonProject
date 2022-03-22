import { Kids } from "./Kids";
import { User } from "./Users";

export interface Messages {
  messageId : number;
  messageContent : string;
  messageDateTime : Date;
  userFromId : number;
  kidId : number;
  userToId : number;
  userFrom: User;
  UserTo: User;
  kid : Kids;
}

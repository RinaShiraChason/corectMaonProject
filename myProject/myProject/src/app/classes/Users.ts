export interface User {
  userId: number;
  userTz: string;
  userName: string;
  address: string;
  email: string;
  phoneNamber1: string;
  phoneNamber2: string;
  password: string;
  userTypeId: number;
  classId?:number;
}

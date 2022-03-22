import { Classes } from "./Classes";
import { User } from "./Users";

export interface PlacementOfATeacher {
  IdPlacementOfATeacher: number;
  dayInWeek1M :number;
  dayInWeek1MStr :string;
  dayInWeek1A :number;
  dayInWeek1AStr :string;
  dayInWeek2M :number;
  dayInWeek2MStr :string;
  dayInWeek2A :number;
  dayInWeek2AStr :string;
  dayInWeek4M :number;
  dayInWeek4MStr :string;
  dayInWeek4A :number;
  dayInWeek4AStr :string;
  dayInWeek3M :number;
  dayInWeek3MStr :string;
  dayInWeek3A :number;
  dayInWeek3AStr :string;
  dayInWeek5M :number;
  dayInWeek5MStr :string;
  dayInWeek5A :number;
  dayInWeek5AStr :string;
  dayInWeek6M :number;
  dayInWeek6MStr :string;
  teacherId: number;
  userTeacher: User;
}

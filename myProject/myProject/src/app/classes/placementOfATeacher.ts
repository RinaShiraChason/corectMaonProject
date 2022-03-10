import { Classes } from "./Classes";
import { User } from "./Users";

export interface PlacementOfATeacher {
  IdPlacementOfATeacher: number;
  DayInWeek1M :number;
  DayInWeek1MStr :string;
  DayInWeek1A :number;
  DayInWeek1AStr :string;
  DayInWeek2M :number;
  DayInWeek2MStr :string;
  DayInWeek2A :number;
  DayInWeek2AStr :string;
  DayInWeek4M :number;
  DayInWeek4MStr :string;
  DayInWeek4A :number;
  DayInWeek4AStr :string;
  DayInWeek3M :number;
  DayInWeek3MStr :string;
  DayInWeek3A :number;
  DayInWeek3AStr :string;
  DayInWeek5M :number;
  DayInWeek5MStr :string;
  DayInWeek5A :number;
  DayInWeek5AStr :string;
  DayInWeek6M :number;
  DayInWeek6MStr :string;
  TeacherId: number;
  UserTeacher: User;
}

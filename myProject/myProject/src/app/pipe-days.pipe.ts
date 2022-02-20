import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'pipeDays'
})
export class PipeDaysPipe implements PipeTransform {

  transform(value: number): unknown {
    switch (value) {
      case 1:
        return 'ראשון';
      case 2:
        return 'שני';
      case 3:
        return 'שלישי';
      case 4:
        return 'רביעי';
      case 5:
        return 'חמישי';
    }
  }

}

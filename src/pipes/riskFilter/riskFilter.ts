import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'riskFilterPipe',
})
export class RiskFilterPipe implements PipeTransform {
  transform(items: Array<any>, conditions: {[field: string]: any}): Array<any> {
    return items.filter(item => {
      for (let field in conditions){
        if (item[field] !== conditions[field]){
          return false;
        }
      }
      return true;
    });
  }
}

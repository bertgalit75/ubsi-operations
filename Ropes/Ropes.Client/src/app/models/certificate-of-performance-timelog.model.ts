import { Time } from '@angular/common';
import { ICertificateOfPerformance } from './certificate-of-performace.model';

export interface ICertificateOfPerformanceTimeLog {
  code: string;
  certificateOfPerformanceCode: string;
  date: Date;
  dateTime: Time;
  certificateOfPerformace: ICertificateOfPerformance;
}

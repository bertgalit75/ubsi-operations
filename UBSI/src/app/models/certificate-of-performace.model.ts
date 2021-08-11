import { ICertificateOfPerformanceTimeLog } from './certificate-of-performance-timelog.model';
import { IImplementationOrder } from './implementation-order.model';

export interface ICertificateOfPerformance {
  code: string;
  implementationOrderCode: string;
  implementationOrder: IImplementationOrder;
  timeLogs: ICertificateOfPerformanceTimeLog[];
}

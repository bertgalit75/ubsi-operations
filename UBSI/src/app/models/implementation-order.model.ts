export interface IImplementationOrder {
  code: string;
  agencyCode: string;
  clientCode: string;
  accountExecutiveCode: string;
  date: Date;
  product: string;
  tagline: string;
  bookingOrderNo: string;
  purchaseOrderNo: string;
  referenceCeNo: string;
  bookings: {
    stationCode: string;
    periodStart: Date;
    periodEnd: Date;
    material: string;
    monday: boolean;
    tuesday: boolean;
    wednesday: boolean;
    thursday: boolean;
    friday: boolean;
    saturday: boolean;
    sunday: boolean;
    noOfSpots: number;
    duration: number;
    grossAmount: number;
  }[];
}

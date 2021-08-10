import { IUserRole } from './user-role.model';

export interface IUser {
  userId: string;
  name: string;
  email: string;
  userRole: IUserRole;
}

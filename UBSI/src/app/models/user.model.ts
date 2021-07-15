import { IRole } from './role.model';

export interface IUser {
  userId: string;
  name: string;
  email: string;
  role: IRole;
}

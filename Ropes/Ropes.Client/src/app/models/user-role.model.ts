import { IRole } from './role.model';

export interface IUserRole {
  userRoleId: number;
  roleId: string;
  userid: string;
  type: string;
  branchId: number;
  role: IRole;
}

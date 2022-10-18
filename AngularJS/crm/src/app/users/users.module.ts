import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatListModule} from '@angular/material/list';
import {MatCardModule} from '@angular/material/card';

import { ListUsersComponent } from './list-users/list-users.component';



@NgModule({
  declarations: [
    ListUsersComponent
  ],
  imports: [
    CommonModule,
    MatListModule,
    MatCardModule
  ],
  exports:[
    ListUsersComponent
  ]
})
export class UsersModule { }

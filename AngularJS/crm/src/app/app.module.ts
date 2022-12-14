import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatSidenavModule} from '@angular/material/sidenav';

import { AppComponent } from './app.component';
import { LayoutModule } from './layout/layout.module';
import { UsersModule } from './users/users.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    LayoutModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatSidenavModule,
    UsersModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

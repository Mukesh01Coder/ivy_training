import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AccountsModule } from './accounts/accounts.module';
// import { NestedModule } from './nested/nested.module';

import { AppComponent } from './app.component';


@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AccountsModule
    // NestedModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

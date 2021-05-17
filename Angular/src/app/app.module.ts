import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule} from '@angular/forms'
import {MatButtonModule} from '@angular/material/button';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { FormCreateComponent } from './form-create/form-create.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { FormUpdateComponent } from './form-update/form-update.component';
import { NavbarComponent } from './navbar/navbar.component';
import { FormDeleteComponent } from './form-delete/form-delete.component';
import { FormListComponent } from './form-list/form-list.component';


@NgModule({
  declarations: [
    AppComponent,
    FormCreateComponent,
    FormUpdateComponent,
    NavbarComponent,
    FormDeleteComponent,
    FormListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatButtonModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

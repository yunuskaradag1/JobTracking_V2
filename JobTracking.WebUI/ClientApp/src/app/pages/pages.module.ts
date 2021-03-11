import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthRoutingModule } from './auth/auth-routing.module';
import { LoginComponent } from './auth/login/login.component';
import { HandleComponent } from './handle/handle.component';



@NgModule({
  declarations: [
    LoginComponent,
    HandleComponent
  ],
  imports: [
    CommonModule,
    AuthRoutingModule
  ],
})
export class PagesModule { }

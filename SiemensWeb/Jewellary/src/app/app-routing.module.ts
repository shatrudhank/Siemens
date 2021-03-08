import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { GoldCalcComponent } from './gold-calc/gold-calc.component';

const routes: Routes = [
 
  { path: 'login', component: LoginComponent },
  { path: '', component: LoginComponent },
  { path: 'calculator', component: GoldCalcComponent },
  { path: '', redirectTo: '/login', pathMatch: 'full',}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

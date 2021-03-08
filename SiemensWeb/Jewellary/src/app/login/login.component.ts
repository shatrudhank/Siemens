import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { first } from 'rxjs/operators';
import { ApiService } from '../api.service';
import { UserModel } from '../model/user-model';

@Component({templateUrl: 'login.component.html'})
export class LoginComponent implements OnInit {
   public userModel: UserModel=new UserModel();
   isInvalid:boolean=false;
   msg:string="";
    constructor(private router: Router, private apiService: ApiService,) {

    
    
    }

    ngOnInit() {

    }
   
    
  close()
  {
    this.userModel.UserId="";
    this.userModel.Password="";
  }


    onSubmit() {
      this.apiService
    .post('http://localhost:58825/api/login',
    this.userModel)
    .subscribe(response => {
    if(response.msgType=="F")
    {
      this.isInvalid=true;
      this.msg=response.msg;
    }
    else{
      this.msg=response.msg;
      sessionStorage.setItem('userType', JSON.stringify(this.msg));
      this.router.navigate(['./calculator']);
    }
     
    });  
      
    }
}

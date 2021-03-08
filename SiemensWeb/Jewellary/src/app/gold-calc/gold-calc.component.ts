import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { first } from 'rxjs/operators';
import { ApiService } from '../api.service';
import { GoldModel } from '../model/gold-model';
import {NgbModal} from '@ng-bootstrap/ng-bootstrap';
@Component({
  selector: 'app-gold-calc',
  templateUrl: './gold-calc.component.html',
  styleUrls: ['./gold-calc.component.css']
})
export class GoldCalcComponent implements OnInit {
  msg:string="";
    $: any;
  userType:string="";
  enableDiscount:boolean=false;
  goldModel:GoldModel=new GoldModel();
  constructor(private router: Router, private apiService: ApiService,private modalService: NgbModal) {

  
  
  }

  ngOnInit(): void {
    this.goldModel.GoldRate=0;
    this.goldModel.GoldWeight=0;
    this.goldModel.GoldDiscount=0;
    this.userType = JSON.parse(sessionStorage.getItem("userType")|| "");
     if( this.userType =="PRIVILAGED")
     {
      this.goldModel.GoldDiscount=2;
        this.enableDiscount=true;
     }
  }

  onSubmit() {
    this.apiService
  .post('http://localhost:58825/api/GoldCalc',
  this.goldModel)
  .subscribe(response => {
    this.msg=response.msg;
  });  
    
  }

  close()
  {
    this.router.navigate(['./']);
  }



}

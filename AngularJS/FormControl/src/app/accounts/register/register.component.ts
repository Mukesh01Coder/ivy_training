import { Component, OnInit } from '@angular/core';
import {FormGroup,FormControl} from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor() { }

  registerForm = new FormGroup({
    Username:new FormControl(''),
    Email:new FormControl(''),
    Password:new FormControl(''),
    ConfirmPassword:new FormControl(''),
  })
  
  Register(){
    alert(this.registerForm.value);
    
  }
  ngOnInit(): void {
  }
  

}

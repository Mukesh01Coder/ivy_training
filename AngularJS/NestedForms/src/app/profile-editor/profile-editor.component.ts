import { state } from '@angular/animations';
import { Component} from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';


@Component({
  selector: 'app-profile-editor',
  templateUrl: './profile-editor.component.html',
  styleUrls: ['./profile-editor.component.css']
})
export class ProfileEditorComponent {
 
  profileForm = new FormGroup({
    firstName: new FormControl(''),
    lastName: new FormControl(''),
    address: new FormGroup({
     
      Country:new FormControl(''),
      state: new FormControl(''),
      city: new FormControl(''),
      street: new FormControl(''),
      PINCode: new FormControl('')
    })
    
  });
  setValues() {
  
   alert(this.profileForm.controls['address'].value.Country);
   console.log(this.profileForm.controls['address'].value);
   console.log(this.profileForm.value.firstName);
  }
}

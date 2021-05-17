import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { EmployeesService } from '../services/employees.service';

@Component({
  selector: 'app-form-delete',
  templateUrl: './form-delete.component.html',
  styleUrls: ['./form-delete.component.scss']
})
export class FormDeleteComponent implements OnInit {

  formDelete : FormGroup;
  
  constructor(private readonly fb: FormBuilder,
    private service: EmployeesService) { }

  ngOnInit(): void {
    this.formDelete = this.fb.group({
      id: new FormControl('',Validators.required),
  })
  }

  get idCtrl(): AbstractControl{
    return this.formDelete.get('id');
  }
 
  
  onDelete(): void{
    this.service.deleteEmployee(this.idCtrl.value).subscribe(
      {
        complete: ()=>{
          alert("Empleado Borrado");
          this.formDelete.reset();
        },
        error: (err)=>{
          alert(err.error?.ExceptionMessage ?? err.error);
        }
      }
    );
  }
}

import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { EmptyError } from 'rxjs';
import { EmployeesService } from '../services/employees.service';
import { Employees } from '../models/Employees';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-form-create',
  templateUrl: './form-create.component.html',
  styleUrls: ['./form-create.component.scss']

})
export class FormCreateComponent implements OnInit {

  formCreate : FormGroup;


  constructor(private readonly fb: FormBuilder,
    private service: EmployeesService,
    private router: Router,
    private route: ActivatedRoute) {
  }


  //Getters

  get nombreCtrl(): AbstractControl{
    return this.formCreate.get('nombre');
  }
  
  get apellidoCtrl(): AbstractControl{
    return this.formCreate.get('apellido');
  }

  get direccionCtrl(): AbstractControl{
    return this.formCreate.get('direccion');
  }

  get ciudadCtrl(): AbstractControl{
    return this.formCreate.get('ciudad');
  }
  
  ngOnInit(): void{
    this.formCreate = this.fb.group({
        nombre: new FormControl('',Validators.required),
        apellido: new FormControl('',Validators.required),
        direccion: new FormControl('',Validators.required),
        ciudad: new FormControl('',Validators.required)
    })
  }
  
  onAdd(): void{
    var emp = new Employees();
    emp.firstName = this.nombreCtrl.value;
    emp.lastName = this.apellidoCtrl.value;
    emp.address = this.direccionCtrl.value;
    emp.city= this.ciudadCtrl.value;
    this.service.postEmployee(emp).subscribe(
      {
        complete: ()=>{
          alert("Empleado agregado");
          this.formCreate.reset();
        },
        error: (err)=>{
          debugger
          alert(err.error?.ExceptionMessage ?? err.error);
        }
      }
    );
  }
}

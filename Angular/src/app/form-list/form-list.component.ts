import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Employees } from '../models/Employees';
import { EmployeesService } from '../services/employees.service';

@Component({
  selector: 'app-form-list',
  templateUrl: './form-list.component.html',
  styleUrls: ['./form-list.component.scss']
})
export class FormListComponent implements OnInit {

  public employees: any[];

  constructor(private readonly fb: FormBuilder,
    private service: EmployeesService) {
      this.service.getEmployees().subscribe(resp =>{
        debugger
        this.employees = resp;
      })
    }

  ngOnInit(): void {
  }

}

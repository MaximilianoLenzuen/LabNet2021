import {HttpClient} from '@angular/common/http'
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment'
import { Employees} from '../models/Employees'

@Injectable({
    providedIn: 'root'
  })
export class EmployeesService{

    constructor(private http: HttpClient){ }
    postEmployee(request: Employees)
    {
        return this.http.post(environment.employees + 'Employees/', request);
    }

    updateEmployee(id : number,request: Employees )
    {
        return this.http.patch(environment.employees + "Employees/" +id,request);
    }

    deleteEmployee(id: number)
    {
        return this.http.delete(environment.employees + 'Employees/' + id); 
    }

    getEmployees(): Observable<any>
    {
        return this.http.get<any>(environment.employees + 'Employees'); 
    }
}

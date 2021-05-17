import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormCreateComponent } from './form-create/form-create.component';
import { FormDeleteComponent } from './form-delete/form-delete.component';
import { FormListComponent } from './form-list/form-list.component';
import { FormUpdateComponent } from './form-update/form-update.component';

const routes: Routes = [
  {
    path: '',
    component: FormCreateComponent
  },
  {
    path: 'update',
    component: FormUpdateComponent
  },
  {
    path: 'delete',
    component: FormDeleteComponent
  }
  ,
  {
    path: 'list',
    component: FormListComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

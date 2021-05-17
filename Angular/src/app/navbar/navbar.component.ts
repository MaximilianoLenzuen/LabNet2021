import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  mostrarAdd = true;
  mostrarList = false;
  mostrarDelete = false;
  mostrarUpdate = false;

  constructor(private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
  }

  goToUpdate() : void{
    this.router.navigate(['update'],{relativeTo: this.route.parent});
  }

  goToDelete() : void{
    this.router.navigate(['delete'],{relativeTo: this.route.parent});
  }

  goToAdd() : void{
    this.router.navigate([''],{relativeTo: this.route.parent});
  }

  goToList() : void{
    this.router.navigate(['list'],{relativeTo: this.route.parent});
  }
}

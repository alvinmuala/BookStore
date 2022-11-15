import { BookClient } from './../clients/book.client';
import { AuthenticationService } from './../services/authentication.service';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-secret',
  templateUrl: './secret.component.html',
  styleUrls: ['./secret.component.css'],
})
export class SecretComponent implements OnInit {
  public book: Observable<any> = this.bookClient.getBookData();
  
  constructor(
    private authenticationService: AuthenticationService,
    private bookClient: BookClient
  ) {}

  ngOnInit(): void {}

  logout(): void {
    this.authenticationService.logout();
  }
}
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({   /* means it can be injected into components or other services */
  providedIn: 'root' /* means you dont have to add it in app.module.ts in providers */
})
export class AccountService {
  baseUrl = 'https://localhost:5001/api/';

  constructor(private http: HttpClient) { }

  login(model: any) {
    return this.http.post(this.baseUrl + 'account/login', model);
  }
}

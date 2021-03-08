import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) {
 }

public get(url: string): Observable<any> {
    return this.http.get(url);
}


public post(url: string, obj: object): Observable<any> {
    return this.http.post(url, obj).pipe(map(user => {
        return user;
    }));
}

}

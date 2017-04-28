﻿import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/do';
import 'rxjs/add/operator/catch';
import { TestUser } from '../models/testUser.model';
import { CONFIG } from './config';

@Injectable()
export class ServerService {

    private _productUrl = 'api/products/products.json';

    constructor(private _http: Http) {

    }

    getUsers(): Observable<TestUser[]> {
        return this._http.get(CONFIG.url.users)
            .map((response: Response) => <TestUser[]>response.json())
            .do(data => console.log('All: ' + JSON.stringify(data)))
            .catch(this.handleError);
    }

    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }

}

import { Component, OnInit } from '@angular/core';
import { TestUser } from '../../../models';
import { ServerService } from '../../../core';


@Component({
    selector: 'shared-header',
    templateUrl: 'header.component.html',
    styleUrls: ['header.component.css']
})

export class HeaderComponent implements OnInit {

    constructor(private _serverService) {
        
    }

    users: TestUser[];
    errorMessage: any;
    currentUser: TestUser;

    ngOnInit(): void {
        console.log('In OnInit');
        this._serverService.getUsers()
            .subscribe(
            users => this.users = users, //function arg 1
            error => this.errorMessage = <any>error); //function arg 2 - success
        this.currentUser = this.users ? this.users[0] : null;
    }
}

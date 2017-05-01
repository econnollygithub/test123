
import { Component, OnInit } from '@angular/core';
import { TestUser } from '../../../models';
import { ApiService } from '../../../core';


@Component({
    selector: 'shared-header',
    templateUrl: 'header.component.html',
    styleUrls: ['header.component.css']
})

export class HeaderComponent implements OnInit {

    constructor(private _apiService: ApiService) {
        
    }

    users: TestUser[] = [];
    errorMessage: any;
    welcomeMessage: string = "Welcome ";
    currentUser: any = null;

    ngOnInit(): void {
        console.log('In OnInit');
        this.refresh();
    }

    private refresh() {
        this.users = [];
        this.currentUser = new TestUser();
        this._apiService.getUsers()
            .subscribe(users => {                           //function arg 1, success
                this.users = users;
                console.log("from component ");
                console.log(this.users);
                this.currentUser = this.users ? this.users[0] : null;
                console.log(this.currentUser);
                this.welcomeMessage += this.currentUser.firstName + "!";
            }),
            error => this.errorMessage = <any>error;        //function arg 2 - error
    }
}

import { CanActivate } from '@angular/router';
import { Injectable } from '@angular/core';

@Injectable()
export class EverySecondGuard implements CanActivate {
    private isValid = false;

    canActivate() {
        this.isValid = !this.isValid;

        if (!this.isValid) {
            alert('Invalid');
        }

        return this.isValid;
    }
}
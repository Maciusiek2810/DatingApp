import { Injectable, Component } from '@angular/core';
import { MemberEditComponent } from '../members/member-edit/member-edit.component';
import { CanDeactivate } from '@angular/router';

@Injectable()
export class PreventUnsavedChanges implements CanDeactivate<MemberEditComponent> {
    canDeactivate(component: MemberEditComponent) {
        if (component.editForm.dirty) {
            return confirm('Czy na pewno chcesz kontynuować? Wszystkie niezapisane zmiany zostaną utracone');
        }
        return true;
    }
}
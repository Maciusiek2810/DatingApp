import { MemberListComponent } from './member-list/member-list.component';
import { HomeComponent } from './home/home.component';
import { ListsComponent } from './lists/lists.component';
import { MessagesComponent } from './messages/messages.component';
import { Routes } from '@angular/router';
import { AuthGuard } from './_guards/auth.guard';
import { PricesComponent } from './prices/prices.component';
import { ContactComponent } from './contact/contact.component';

export const appRoutes: Routes = [
  { path: 'home', component: HomeComponent },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      { path: 'members', component: MemberListComponent },
      { path: 'messages', component: MessagesComponent },
      { path: 'lists', component: ListsComponent },
      { path: 'prices', component: PricesComponent },
      { path: 'contact', component: ContactComponent }
    ]
  },
  { path: '**', redirectTo: 'home', pathMatch: 'full' }
];

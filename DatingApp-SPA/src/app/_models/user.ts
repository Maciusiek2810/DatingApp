import { HttpDownloadProgressEvent } from '@angular/common/http';
import { Photo } from './photo';

export interface User {
  id: number;
  username: string;
  email: string;
  created: Date;
  lastActive: Date;
  photoUrl: string;
  photos?: Photo[];
  city: string;
  street: string;
  phone: string;
  postalCode: number;
  // country: string;
  // interests?: string;
  // introduction?: string;
  // lookingFor?: string;
  // knownAs: string;
  // age: number;
  // gender: string;
}

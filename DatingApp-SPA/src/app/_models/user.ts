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
  // knownAs: string;
  // age: number;
  // gender: string;
  // city: string;
  // country: string;
  // interests?: string;
  // introduction?: string;
  // lookingFor?: string;
}

import { Bike } from "../bike/bike";

export interface Updateperson {
    email: string;
    name: string;
    surname: string;
    birth: string;
    sex: string;
    passwordd: string;
    nation: string;
    taxcode: string;
    biciId: number | null;
    bici: Bike;

}

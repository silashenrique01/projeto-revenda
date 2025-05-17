import { Revenda } from "./Revenda";

export class Pedido {
    id:string;
    produtos:Produto[] = [];
    revendaId:string;
    revenda:Revenda;
    clienteId:string;
}


export class Produto {
    quantidade:string;
    nome:string;
}



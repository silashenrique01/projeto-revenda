import { Revenda } from "./Revenda";

export class Pedido {
    id:string;
    produtos:Produto[] = [];
    revendaId:string;
    revenda:string;
    clienteId:string;
}


export class Produto {
    quantidade:string;
    nome:string;
}



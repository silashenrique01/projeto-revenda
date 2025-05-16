export class Revenda {
  id:string;
  cnpj: string;
  razaoSocial: string;
  nomeFantasia: string;
  email: string;
  telefones: Telefone[] = [];
  contatos: Contato[] = [];
  enderecos: Endereco[] = [];
}

export class Telefone {
  numero: string;
}

export class Contato {
  nome: string;
  sobrenome: string;
  contatoPrincipal: boolean;
}

export class Endereco {
  longradouro: string;
  numero: string;
  cidade: string;
  estado: string;
  bairro: string;
  cep: string;
  complemento: string;
  pontoReferencia:string;
}
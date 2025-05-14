export interface Revenda {
  cnpj: string;
  razaoSocial: string;
  nomeFantasia: string;
  email: string;
  telefones: Telefone[];
  contatos: Contato[];
  enderecos: Endereco[];
}

export interface Telefone {
  numero: string;
}

export interface Contato {
  nome: string;
  sobrenome: string;
  contatoPrincipal: boolean;
}

export interface Endereco {
  longradouro: string;
  numero: string;
  cidade: string;
  estado: string;
  bairro: string;
  cep: string;
  complemento: string;
  pontoReferencia:string;
}
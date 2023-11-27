import { BiList } from "../../assets/svg/BiList.svg";

const Navbar = () => {
  return (
    <nav className="fixed top-0 z-50 flex max-h-14 w-full items-center justify-between bg-gradient-to-r from-sky-800 to-blue-600 px-8 py-2 text-white md:px-48">
      <a href="/" className="flex items-center text-2xl">
        <img src="/assets/logo.png" alt="logo" className="mr-2 h-12" />
        <span>Activehub</span>
      </a>
      <button>
        <BiList className="h-10 w-10 rounded border-[1px] border-slate-200 border-opacity-20 stroke-slate-200 p-1 md:hidden" />
      </button>
      <ul className="hidden items-center gap-4 md:flex [&>li>a:hover]:text-cyan-400 [&>li]:font-semibold">
        <li>
          <a href="#">Atividades</a>
        </li>
        <li className="rounded bg-green-700 p-2 hover:bg-green-600">
          <button>Criar atividade</button>
        </li>
      </ul>
    </nav>
  );
};

export default Navbar;

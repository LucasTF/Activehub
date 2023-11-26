const Navbar = () => {
  return (
    <nav className="fixed top-0 z-50 flex max-h-14 w-full items-center justify-between bg-gradient-to-r from-sky-800 to-blue-600 px-48 py-2 text-white">
      <a href="/" className="flex items-center text-2xl">
        <img src="/assets/logo.png" alt="logo" className="mr-2 h-12" />
        <span>Activehub</span>
      </a>
      <ul className="flex items-center gap-4 [&>li>a:hover]:text-cyan-400 [&>li]:font-semibold">
        <li>
          <a href="#">Atividades</a>
        </li>
        <li className="cursor-pointer rounded bg-green-700 p-2 hover:bg-green-600">
          <button>Criar atividade</button>
        </li>
      </ul>
    </nav>
  );
};

export default Navbar;

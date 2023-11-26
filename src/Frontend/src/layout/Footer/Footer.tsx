const Footer = () => {
  const currentYear = new Date().getFullYear();

  return (
    <footer className="mt-auto bg-gradient-to-r from-sky-800 to-blue-600 py-4 text-center font-semibold text-white">
      <p>Activehub &copy; {currentYear}</p>
    </footer>
  );
};

export default Footer;
